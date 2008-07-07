-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, active, score, owner, count) VALUES ('standard', 98, 36.06, 'staging', 38);
INSERT INTO layout_items (token, active, score, owner, count) VALUES ('strict', 99, 46.95, 'fallback', 19);
