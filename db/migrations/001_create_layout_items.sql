-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, rank, token, score, active) VALUES (44.8, 92, 'standard', 21.42, 36);
INSERT INTO layout_items (weight, rank, token, score, active) VALUES (59.86, 69, 'local', 66.1, 30);
INSERT INTO layout_items (weight, rank, token, score, active) VALUES (0.03, 12, 'stable', 69.29, 90);
