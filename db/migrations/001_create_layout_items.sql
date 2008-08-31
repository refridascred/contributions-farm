-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, weight, ratio) VALUES ('standard', 82.94, 77.51);
INSERT INTO layout_items (region, weight, ratio) VALUES ('staging', 65.3, 78.9);
INSERT INTO layout_items (region, weight, ratio) VALUES ('staging', 68.24, 62.85);
