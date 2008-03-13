-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, ratio, weight, count) VALUES ('cached', 68.38, 60.37, 3);
INSERT INTO layout_items (owner, ratio, weight, count) VALUES ('local', 45.26, 79.11, 48);
INSERT INTO layout_items (owner, ratio, weight, count) VALUES ('stable', 43.05, 71.25, 33);
