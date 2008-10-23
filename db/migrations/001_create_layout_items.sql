-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, ratio, token, state) VALUES ('cached', 93.02, 'standard', 'stable');
INSERT INTO layout_items (region, ratio, token, state) VALUES ('latest', 72.82, 'stable', 'green');
INSERT INTO layout_items (region, ratio, token, state) VALUES ('local', 82.37, 'green', 'cached');
