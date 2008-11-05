-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, rank, score, active) VALUES ('stable', 71, 62.19, 73);
INSERT INTO layout_items (token, rank, score, active) VALUES ('local', 39, 53.12, 8);
INSERT INTO layout_items (token, rank, score, active) VALUES ('stable', 27, 71.9, 29);
