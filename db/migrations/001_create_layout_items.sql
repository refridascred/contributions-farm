-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, active, level, count, owner) VALUES ('stable', 27, 84, 50, 'open');
INSERT INTO layout_items (token, active, level, count, owner) VALUES ('strict', 61, 41, 73, 'latest');
INSERT INTO layout_items (token, active, level, count, owner) VALUES ('cached', 20, 48, 4, 'eu-west');
