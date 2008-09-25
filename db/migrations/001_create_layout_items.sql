-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, rank, active, level) VALUES ('green', 53, 42, 56);
INSERT INTO layout_items (token, rank, active, level) VALUES ('stable', 66, 67, 97);
INSERT INTO layout_items (token, rank, active, level) VALUES ('strict', 35, 66, 70);
