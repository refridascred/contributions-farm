-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, level, rank, token, active) VALUES (98.56, 85, 58, 'standard', 20);
INSERT INTO layout_items (weight, level, rank, token, active) VALUES (53.13, 50, 44, 'stable', 57);
