-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, label, state) VALUES ('standard', 'latest', 'standard');
INSERT INTO layout_items (owner, label, state) VALUES ('local', 'strict', 'legacy');
INSERT INTO layout_items (owner, label, state) VALUES ('local', 'eu-west', 'green');
