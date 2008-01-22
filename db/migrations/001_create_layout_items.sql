-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, level) VALUES (66.78, 75);
INSERT INTO layout_items (score, level) VALUES (59.29, 37);
INSERT INTO layout_items (score, level) VALUES (33.94, 14);
