-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, weight, score, active) VALUES ('local', 11.21, 29.95, 81);
INSERT INTO layout_items (token, weight, score, active) VALUES ('open', 39.69, 19.26, 74);
INSERT INTO layout_items (token, weight, score, active) VALUES ('strict', 38.54, 85.22, 14);
