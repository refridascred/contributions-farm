-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (count, token, score, owner, active) VALUES (35, 'strict', 56.98, 'strict', 55);
INSERT INTO layout_items (count, token, score, owner, active) VALUES (23, 'latest', 4.99, 'staging', 54);
INSERT INTO layout_items (count, token, score, owner, active) VALUES (25, 'legacy', 78.71, 'stable', 39);
