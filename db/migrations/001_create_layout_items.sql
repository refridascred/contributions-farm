-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, token, state, label) VALUES (78.59, 'cached', 'latest', 'green');
INSERT INTO layout_items (ratio, token, state, label) VALUES (50.41, 'open', 'green', 'staging');
INSERT INTO layout_items (ratio, token, state, label) VALUES (26.48, 'green', 'latest', 'legacy');
