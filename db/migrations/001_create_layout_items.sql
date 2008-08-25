-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, active, level, weight) VALUES (9.3, 10, 81, 61.58);
INSERT INTO layout_items (score, active, level, weight) VALUES (22.8, 80, 78, 9.72);
INSERT INTO layout_items (score, active, level, weight) VALUES (67.7, 27, 77, 28.59);
