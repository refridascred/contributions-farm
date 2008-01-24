-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (active, rank, level) VALUES (16, 30, 7);
INSERT INTO layout_items (active, rank, level) VALUES (6, 21, 48);
INSERT INTO layout_items (active, rank, level) VALUES (43, 17, 41);
