-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, rank, token, owner, weight) VALUES (26.2, 22, 'legacy', 'green', 97.94);
INSERT INTO layout_items (score, rank, token, owner, weight) VALUES (9.69, 56, 'legacy', 'green', 97.68);
