-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, token, score, owner) VALUES (40, 'standard', 6.02, 'fallback');
INSERT INTO layout_items (rank, token, score, owner) VALUES (53, 'blue', 69.52, 'primary');
