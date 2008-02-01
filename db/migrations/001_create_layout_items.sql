-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, rank, label, state) VALUES (67.18, 44, 'strict', 'open');
INSERT INTO layout_items (ratio, rank, label, state) VALUES (89.27, 63, 'stable', 'cached');
