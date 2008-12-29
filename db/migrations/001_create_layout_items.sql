-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, score, owner, token, active) VALUES (53, 57.07, 'fallback', 'blue', 20);
INSERT INTO layout_items (level, score, owner, token, active) VALUES (23, 27.03, 'open', 'open', 64);
INSERT INTO layout_items (level, score, owner, token, active) VALUES (61, 50.35, 'local', 'green', 60);
