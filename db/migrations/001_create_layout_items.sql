-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, weight, level, ratio, region) VALUES ('legacy', 82.52, 55, 77.13, 'primary');
INSERT INTO layout_items (owner, weight, level, ratio, region) VALUES ('staging', 49.66, 87, 96.26, 'blue');
