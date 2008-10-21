-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (score, level, weight) VALUES (52.87, 11, 39.07);
INSERT INTO layout_items (score, level, weight) VALUES (55.88, 1, 16.32);
INSERT INTO layout_items (score, level, weight) VALUES (8.03, 16, 89.1);
