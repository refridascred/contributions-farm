-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, token, rank, owner, ratio) VALUES (45, 'local', 69, 'fallback', 43.31);
INSERT INTO layout_items (active, token, rank, owner, ratio) VALUES (65, 'open', 18, 'standard', 98.35);
INSERT INTO layout_items (active, token, rank, owner, ratio) VALUES (28, 'strict', 65, 'latest', 63.81);
