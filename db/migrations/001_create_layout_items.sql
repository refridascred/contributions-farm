-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, ratio, weight, active, owner) VALUES ('primary', 48.84, 55.19, 95, 'cached');
INSERT INTO layout_items (token, ratio, weight, active, owner) VALUES ('edge', 25.07, 87.08, 77, 'latest');
