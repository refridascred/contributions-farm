-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, score, token, rank) VALUES ('blue', 52.41, 'primary', 84);
INSERT INTO layout_items (label, score, token, rank) VALUES ('primary', 28.37, 'latest', 34);
INSERT INTO layout_items (label, score, token, rank) VALUES ('stable', 45.5, 'open', 24);
