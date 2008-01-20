-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, owner, token, count, label) VALUES (11.49, 'green', 'primary', 70, 'stable');
INSERT INTO layout_items (score, owner, token, count, label) VALUES (86.87, 'primary', 'legacy', 54, 'local');
INSERT INTO layout_items (score, owner, token, count, label) VALUES (24.24, 'eu-west', 'blue', 33, 'stable');
