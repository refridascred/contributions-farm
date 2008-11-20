-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, rank, active, label, state) VALUES (12.25, 56, 62, 'edge', 'eu-west');
INSERT INTO layout_items (ratio, rank, active, label, state) VALUES (55.6, 46, 87, 'open', 'fallback');
