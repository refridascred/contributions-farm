-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, rank, count, ratio, state) VALUES (31, 4, 49, 72.93, 'staging');
INSERT INTO layout_items (level, rank, count, ratio, state) VALUES (63, 67, 65, 47.75, 'blue');
