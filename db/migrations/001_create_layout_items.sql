-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, weight, level, region) VALUES ('primary', 76.31, 21, 'staging');
INSERT INTO layout_items (label, weight, level, region) VALUES ('strict', 18.64, 67, 'cached');
