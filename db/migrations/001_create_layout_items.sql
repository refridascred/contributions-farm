-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (state, level, count, rank, label) VALUES ('local', 11, 84, 80, 'blue');
INSERT INTO layout_items (state, level, count, rank, label) VALUES ('open', 70, 11, 33, 'eu-west');
INSERT INTO layout_items (state, level, count, rank, label) VALUES ('standard', 7, 63, 95, 'latest');
