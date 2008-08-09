-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, level, rank, weight) VALUES (95.75, 79, 80, 32.22);
INSERT INTO layout_items (score, level, rank, weight) VALUES (14.85, 95, 97, 9.88);
INSERT INTO layout_items (score, level, rank, weight) VALUES (66.17, 73, 90, 29.59);
