-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, token, level) VALUES (7.96, 'standard', 10);
INSERT INTO layout_items (score, token, level) VALUES (96.15, 'eu-west', 28);
INSERT INTO layout_items (score, token, level) VALUES (49.42, 'local', 84);
