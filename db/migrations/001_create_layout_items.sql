-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, score, active) VALUES ('legacy', 35.18, 35);
INSERT INTO layout_items (token, score, active) VALUES ('strict', 97.96, 64);
INSERT INTO layout_items (token, score, active) VALUES ('eu-west', 22.63, 0);
