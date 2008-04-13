-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, owner, count, score) VALUES ('green', 'blue', 4, 48.46);
INSERT INTO layout_items (token, owner, count, score) VALUES ('legacy', 'strict', 83, 89.94);
INSERT INTO layout_items (token, owner, count, score) VALUES ('strict', 'strict', 54, 25.18);
