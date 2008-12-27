-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, rank, ratio) VALUES (84, 75, 91.21);
INSERT INTO layout_items (level, rank, ratio) VALUES (2, 11, 89.17);
INSERT INTO layout_items (level, rank, ratio) VALUES (15, 50, 27.5);
