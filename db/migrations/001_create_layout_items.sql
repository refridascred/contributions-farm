-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, owner, score, token, level) VALUES (3, 'eu-west', 20.81, 'blue', 63);
INSERT INTO layout_items (rank, owner, score, token, level) VALUES (4, 'blue', 71.69, 'blue', 19);
