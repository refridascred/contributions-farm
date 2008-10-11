-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, count, weight, owner) VALUES (62, 25, 4.2, 'standard');
INSERT INTO layout_items (level, count, weight, owner) VALUES (59, 76, 6.98, 'latest');
INSERT INTO layout_items (level, count, weight, owner) VALUES (54, 31, 75.31, 'latest');
