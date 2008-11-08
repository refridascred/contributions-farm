-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, region, rank) VALUES ('edge', 'legacy', 83);
INSERT INTO layout_items (token, region, rank) VALUES ('cached', 'fallback', 24);
INSERT INTO layout_items (token, region, rank) VALUES ('blue', 'standard', 44);
