-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, score) VALUES ('standard', 60.19);
INSERT INTO layout_items (token, score) VALUES ('edge', 62.42);
INSERT INTO layout_items (token, score) VALUES ('green', 33.59);
