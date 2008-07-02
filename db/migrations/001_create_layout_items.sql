-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, state, region, rank, ratio) VALUES (71, 'local', 'open', 2, 17.99);
INSERT INTO layout_items (active, state, region, rank, ratio) VALUES (44, 'primary', 'open', 54, 39.09);
