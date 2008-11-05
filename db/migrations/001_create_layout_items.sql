-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, ratio) VALUES ('eu-west', 'legacy', 21.22);
INSERT INTO layout_items (region, token, ratio) VALUES ('blue', 'strict', 46.9);
INSERT INTO layout_items (region, token, ratio) VALUES ('cached', 'green', 52.44);
