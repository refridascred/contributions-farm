-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, weight, level) VALUES (23.89, 2.23, 44);
INSERT INTO layout_items (score, weight, level) VALUES (42.22, 18.33, 65);
INSERT INTO layout_items (score, weight, level) VALUES (17.56, 11.64, 60);
