-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (score, rank, ratio, token, owner) VALUES (29.32, 81, 80.59, 'local', 'strict');
INSERT INTO layout_items (score, rank, ratio, token, owner) VALUES (51.25, 83, 97.89, 'primary', 'green');
INSERT INTO layout_items (score, rank, ratio, token, owner) VALUES (77.75, 39, 38.64, 'stable', 'stable');
