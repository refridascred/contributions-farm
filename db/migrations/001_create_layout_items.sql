-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, ratio, token, label) VALUES ('primary', 64.51, 'local', 'cached');
INSERT INTO layout_items (state, ratio, token, label) VALUES ('local', 94.75, 'standard', 'legacy');
