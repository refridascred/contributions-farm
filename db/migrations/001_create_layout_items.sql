-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, weight) VALUES (20.29, 11.22);
INSERT INTO layout_items (score, weight) VALUES (66.86, 77.02);
INSERT INTO layout_items (score, weight) VALUES (41.85, 96.6);
