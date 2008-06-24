-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, ratio, state, count) VALUES ('eu-west', 85.98, 'open', 88);
INSERT INTO layout_items (token, ratio, state, count) VALUES ('standard', 90.51, 'eu-west', 33);
