-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, active, token, weight, score) VALUES (95, 31, 'legacy', 26.79, 11.8);
INSERT INTO layout_items (rank, active, token, weight, score) VALUES (10, 9, 'staging', 7.55, 34.13);
INSERT INTO layout_items (rank, active, token, weight, score) VALUES (73, 5, 'strict', 60.41, 24.96);
