-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, label) VALUES ('open', 91.42, 'strict');
INSERT INTO layout_items (region, ratio, label) VALUES ('latest', 25.58, 'cached');
INSERT INTO layout_items (region, ratio, label) VALUES ('primary', 63.9, 'legacy');
