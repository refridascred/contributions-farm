-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, active, score, owner, count) VALUES ('strict', 35, 86.58, 'standard', 90);
INSERT INTO layout_items (token, active, score, owner, count) VALUES ('legacy', 7, 41.23, 'strict', 69);
INSERT INTO layout_items (token, active, score, owner, count) VALUES ('primary', 7, 93.57, 'blue', 54);
