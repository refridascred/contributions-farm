-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, score, label, level) VALUES ('standard', 97.48, 'eu-west', 74);
INSERT INTO layout_items (token, score, label, level) VALUES ('edge', 74.22, 'open', 90);
