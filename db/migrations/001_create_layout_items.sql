-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, token, state) VALUES ('stable', 'primary', 'eu-west');
INSERT INTO layout_items (owner, token, state) VALUES ('primary', 'local', 'edge');
INSERT INTO layout_items (owner, token, state) VALUES ('strict', 'open', 'blue');
