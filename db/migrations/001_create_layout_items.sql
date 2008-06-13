-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, owner, state, region) VALUES ('fallback', 'eu-west', 'green', 'blue');
INSERT INTO layout_items (token, owner, state, region) VALUES ('latest', 'local', 'open', 'latest');
INSERT INTO layout_items (token, owner, state, region) VALUES ('blue', 'staging', 'strict', 'strict');
