-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, count, label, rank, state) VALUES (63.41, 59, 'local', 35, 'standard');
INSERT INTO layout_items (ratio, count, label, rank, state) VALUES (23.27, 70, 'latest', 37, 'fallback');
