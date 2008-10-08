-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, ratio, region, weight, count) VALUES ('legacy', 19.84, 'blue', 50.33, 26);
INSERT INTO layout_items (token, ratio, region, weight, count) VALUES ('legacy', 0.02, 'local', 77.06, 1);
