-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, region, count, state, rank) VALUES ('cached', 'strict', 8, 'open', 23);
INSERT INTO layout_items (label, region, count, state, rank) VALUES ('standard', 'primary', 40, 'staging', 7);
