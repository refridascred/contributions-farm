-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, state, ratio, label) VALUES (77, 'strict', 6.02, 'open');
INSERT INTO layout_items (rank, state, ratio, label) VALUES (7, 'primary', 72.09, 'open');
INSERT INTO layout_items (rank, state, ratio, label) VALUES (87, 'primary', 97.79, 'fallback');
