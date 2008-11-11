-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, label, token, region) VALUES ('stable', 'eu-west', 'fallback', 'strict');
INSERT INTO layout_items (state, label, token, region) VALUES ('open', 'latest', 'open', 'green');
