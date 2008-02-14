-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, state, token, rank, label) VALUES (14.72, 'fallback', 'latest', 47, 'latest');
INSERT INTO layout_items (ratio, state, token, rank, label) VALUES (89.0, 'staging', 'eu-west', 52, 'stable');
