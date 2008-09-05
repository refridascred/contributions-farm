-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, owner, level, ratio, score) VALUES (40.64, 'cached', 54, 14.97, 95.07);
INSERT INTO layout_items (weight, owner, level, ratio, score) VALUES (96.65, 'stable', 45, 30.8, 55.95);
INSERT INTO layout_items (weight, owner, level, ratio, score) VALUES (50.79, 'green', 11, 94.92, 98.07);
