-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (state, count, rank, level, label) VALUES ('local', 7, 93, 36, 'standard');
INSERT INTO layout_items (state, count, rank, level, label) VALUES ('eu-west', 66, 97, 26, 'primary');
INSERT INTO layout_items (state, count, rank, level, label) VALUES ('staging', 27, 41, 68, 'legacy');
