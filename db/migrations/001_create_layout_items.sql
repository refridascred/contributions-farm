-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    region TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, label, region, level, weight) VALUES (97.92, 'latest', 'local', 81, 81.27);
INSERT INTO layout_items (ratio, label, region, level, weight) VALUES (23.97, 'latest', 'staging', 82, 91.26);
INSERT INTO layout_items (ratio, label, region, level, weight) VALUES (65.05, 'edge', 'blue', 48, 34.63);
