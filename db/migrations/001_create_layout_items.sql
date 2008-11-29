-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, ratio) VALUES ('green', 'legacy', 57.58);
INSERT INTO layout_items (region, token, ratio) VALUES ('staging', 'open', 30.46);
INSERT INTO layout_items (region, token, ratio) VALUES ('staging', 'cached', 88.56);
