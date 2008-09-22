-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, state, region, rank) VALUES (56, 'local', 'open', 42);
INSERT INTO layout_items (active, state, region, rank) VALUES (76, 'green', 'stable', 46);
