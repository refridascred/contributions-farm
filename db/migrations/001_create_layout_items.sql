-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, ratio) VALUES ('primary', 'legacy', 51.06);
INSERT INTO layout_items (region, token, ratio) VALUES ('stable', 'stable', 2.82);
