-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, weight, region, level, label) VALUES ('legacy', 23.88, 'green', 58, 'local');
INSERT INTO layout_items (owner, weight, region, level, label) VALUES ('edge', 69.86, 'cached', 51, 'open');
INSERT INTO layout_items (owner, weight, region, level, label) VALUES ('primary', 27.56, 'legacy', 70, 'strict');
